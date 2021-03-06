﻿namespace UglyToad.PdfPig.DocumentLayoutAnalysis.Export.PAGE
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    public partial class PageXmlDocument
    {
        /// <summary>
        /// Container for one-to-one relations between layout
        /// objects (for example: DropCap - paragraph, caption -
        /// image).
        /// </summary>
        [EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCode("xsd", "4.6.1055.0")]
        [Serializable()]
        [DebuggerStepThrough()]
        [DesignerCategory("code")]
        [XmlType(Namespace = "http://schema.primaresearch.org/PAGE/gts/pagecontent/2019-07-15")]
        public class PageXmlRelations
        {

            private PageXmlRelation[] relationField;

            /// <remarks/>
            [XmlElement("Relation")]
            public PageXmlRelation[] Relations
            {
                get
                {
                    return this.relationField;
                }
                set
                {
                    this.relationField = value;
                }
            }
        }
    }
}
