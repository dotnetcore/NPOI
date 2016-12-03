
/* ====================================================================
   Licensed to the Apache Software Foundation (ASF) under one or more
   contributor license agreements.  See the NOTICE file distributed with
   this work for Additional information regarding copyright ownership.
   The ASF licenses this file to You under the Apache License, Version 2.0
   (the "License"); you may not use this file except in compliance with
   the License.  You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
==================================================================== */


using System;
using System.Collections;

using Npoi.Core.POIFS.FileSystem;
using System.Collections.Generic;

namespace Npoi.Core.POIFS.EventFileSystem
{
    /**
     * A registry for POIFSReaderListeners and the DocumentDescriptors of
     * the documents those listeners are interested in
     *
     * @author Marc Johnson (mjohnson at apache dot org)
     * @version %I%, %G%
     */

    public class POIFSReaderRegistry
    {

        // the POIFSReaderListeners who listen to all POIFSReaderEvents
        private List<object> omnivorousListeners;

        // Each mapping in this Map has a key consisting of a
        // POIFSReaderListener and a value cosisting of a Set of
        // DocumentDescriptors for the documents that POIFSReaderListener
        // is interested in; used to efficiently manage the registry
        private Dictionary<object, object> selectiveListeners;

        // Each mapping in this Map has a key consisting of a
        // DocumentDescriptor and a value consisting of a Set of
        // POIFSReaderListeners for the document matching that
        // DocumentDescriptor; used when a document is found, to quickly
        // Get the listeners interested in that document
        private Dictionary<object, object> chosenDocumentDescriptors;

        /**
         * Construct the registry
         */

        public POIFSReaderRegistry() {
            omnivorousListeners = new List<object>();
            selectiveListeners = new Dictionary<object, object>();
            chosenDocumentDescriptors = new Dictionary<object, object>();
        }

        /**
         * Register a POIFSReaderListener for a particular document
         *
         * @param listener the listener
         * @param path the path of the document of interest
         * @param documentName the name of the document of interest
         */

        public void RegisterListener(POIFSReaderListener listener,
                              POIFSDocumentPath path,
                              String documentName) {
            if (!omnivorousListeners.Contains(listener)) {

                // not an omnivorous listener (if it was, this method is a
                // no-op)
                List<object> descriptors = (List<object>)selectiveListeners[listener];

                if (descriptors == null) {

                    // this listener has not Registered before
                    descriptors = new List<object>();
                    selectiveListeners[listener] = descriptors;
                }
                DocumentDescriptor descriptor = new DocumentDescriptor(path,
                                                    documentName);

                descriptors.Add(descriptor);


                // this listener wasn't alReady listening for this
                // document -- Add the listener to the Set of
                // listeners for this document
                List<object> listeners =
                        (List<object>)chosenDocumentDescriptors[descriptor];

                if (listeners == null) {

                    // nobody was listening for this document before
                    listeners = new List<object>();
                    chosenDocumentDescriptors[descriptor] = listeners;
                }
                listeners.Add(listener);

            }
        }

        /**
         * Register for all documents
         *
         * @param listener the listener who wants to Get all documents
         */

        public void RegisterListener(POIFSReaderListener listener) {
            if (!omnivorousListeners.Contains(listener)) {

                // wasn't alReady listening for everything, so drop
                // anything listener might have been listening for and
                // then Add the listener to the Set of omnivorous
                // listeners
                RemoveSelectiveListener(listener);
                omnivorousListeners.Add(listener);
            }
        }

        /**
         * Get am iterator of listeners for a particular document
         *
         * @param path the document path
         * @param name the name of the document
         *
         * @return an Iterator POIFSReaderListeners; may be empty
         */

        public IEnumerator GetListeners(POIFSDocumentPath path, String name) {
            List<object> rval = new List<object>(omnivorousListeners);
            List<object> selectiveListeners =
                (List<object>)chosenDocumentDescriptors[new DocumentDescriptor(path,
                    name)];

            if (selectiveListeners != null) {
                rval.AddRange(selectiveListeners);
            }
            return rval.GetEnumerator();
        }

        private void RemoveSelectiveListener(POIFSReaderListener listener) {
            List<object> selectedDescriptors = (List<object>)selectiveListeners[listener];

            if (selectedDescriptors != null) {
                selectiveListeners.Remove(listener);
                IEnumerator iter = selectedDescriptors.GetEnumerator();

                while (iter.MoveNext()) {
                    DropDocument(listener, (DocumentDescriptor)iter.Current);
                }
            }
        }

        private void DropDocument(POIFSReaderListener listener,
                                  DocumentDescriptor descriptor) {
            List<object> listeners = (List<object>)chosenDocumentDescriptors[descriptor];

            listeners.Remove(listener);
            if (listeners.Count == 0) {
                chosenDocumentDescriptors.Remove(descriptor);
            }
        }
    }   // end package scope class POIFSReaderRegistry

}