#pragma warning disable 649    // disable compiler warnings about unassigned fields

namespace Fams.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web.DomainServices;
    using System.Web.Ria;
    using System.Web.Ria.Services;


    // The MetadataTypeAttribute identifies fls_LICENCE_INFOMetadata as the class
    // that carries additional metadata for the fls_LICENCE_INFO class.
    [MetadataTypeAttribute(typeof(fls_LICENCE_INFO.fls_LICENCE_INFOMetadata))]
    public partial class fls_LICENCE_INFO
    {

        // This class allows you to attach custom attributes to properties
        // of the fls_LICENCE_INFO class.
        //
        // For example, the following marks the Xyz property as a
        // required field and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz;
        internal sealed class fls_LICENCE_INFOMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private fls_LICENCE_INFOMetadata()
            {
            }

            public string COMMENTS;

            public int comp_id;

            public fls_COMPANY_INFO fls_COMPANY_INFO;

            public int id;

            public Nullable<DateTime> LIC_EXPIRY_DATE;

            public Nullable<DateTime> LIC_ISSU_DATE;

            public string LICENCE;
        }
    }
}

#pragma warning restore 649    // re-enable compiler warnings about unassigned fields
