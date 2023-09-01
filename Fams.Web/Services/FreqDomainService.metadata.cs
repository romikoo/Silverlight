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


    // The MetadataTypeAttribute identifies Fams_FreqMetadata as the class
    // that carries additional metadata for the Fams_Freq class.
    [MetadataTypeAttribute(typeof(Fams_Freq.Fams_FreqMetadata))]
    public partial class Fams_Freq
    {

        // This class allows you to attach custom attributes to properties
        // of the Fams_Freq class.
        //
        // For example, the following marks the Xyz property as a
        // required field and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz;
        internal sealed class Fams_FreqMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private Fams_FreqMetadata()
            {
            }

            public int BandWidth;

            public fls_LICENCE_INFO fls_LICENCE_INFO;

            public long freq;

            public int id;

            public int licence_id;

            public bool reestrit;

            public string remark;

            public Nullable<int> zone_city_id;
        }
    }
}

#pragma warning restore 649    // re-enable compiler warnings about unassigned fields
