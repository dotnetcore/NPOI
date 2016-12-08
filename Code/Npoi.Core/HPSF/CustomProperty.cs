/* ====================================================================
   Licensed To the Apache Software Foundation (ASF) under one or more
   contributor license agreements.  See the NOTICE file distributed with
   this work for Additional information regarding copyright ownership.
   The ASF licenses this file To You under the Apache License, Version 2.0
   (the "License"); you may not use this file except in compliance with
   the License.  You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed To in writing, software
   distributed under the License is distributed on an "AS Is" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
==================================================================== */

/* ================================================================
 * About NPOI
 * Author: Tony Qu
 * Author's email: tonyqus (at) gmail.com
 * Author's Blog: tonyqus.wordpress.com.cn (wp.tonyqus.cn)
 * HomePage: http://www.codeplex.com/npoi
 * Contributors:
 *
 * ==============================================================*/

namespace Npoi.Core.HPSF
{
    using System;

    /// <summary>
    /// This class represents custum properties in the document summary
    /// information stream. The difference To normal properties is that custom
    /// properties have an optional name. If the name is not <c>null</c> it
    /// will be maintained in the section's dictionary.
    /// @author Rainer Klute
    /// <a href="mailto:klute@rainer-klute.de">&lt;klute@rainer-klute.de&gt;</a>
    /// @since 2006-02-09
    /// </summary>
    public class CustomProperty : MutableProperty
    {
        private string name;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomProperty"/> class.
        /// </summary>
        public CustomProperty() {
            name = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomProperty"/> class.
        /// </summary>
        /// <param name="property">the property To copy</param>
        public CustomProperty(Property property) :
            this(property, "") //change null to "" by Tony Qu
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomProperty"/> class.
        /// </summary>
        /// <param name="property">This property's attributes are copied To the new custom
        /// property.</param>
        /// <param name="name">The new custom property's name.</param>
        public CustomProperty(Property property, String name) : base(property) {
            this.name = name;
        }

        /// <summary>
        /// Gets or sets the property's name.
        /// </summary>
        /// <value>the property's name.</value>
        public String Name {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Compares two custom properties for equality. The method returns
        /// <c>true</c> if all attributes of the two custom properties are
        /// equal.
        /// </summary>
        /// <param name="o">The custom property To Compare with.</param>
        /// <returns><c>true</c>
        ///  if both custom properties are equal, else
        /// <c>false</c></returns>
        public bool EqualsContents(object o) {
            CustomProperty c = (CustomProperty)o;
            String name1 = c.Name;
            String name2 = Name;
            bool equalNames = true;
            if (name1 == null)
                equalNames = name2 == null;
            else
                equalNames = name1.Equals(name2);
            return equalNames && c.ID == ID
                    && c.Type == Type
                    && c.Value.Equals(Value);
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        /// @see object#GetHashCode()
        public override int GetHashCode() {
            return (int)ID;
        }
    }
}