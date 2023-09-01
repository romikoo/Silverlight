#pragma warning disable 649    // disable compiler warnings about unassigned fields

namespace Fams.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Linq;
    using System.Linq;
    using System.Web.DomainServices;
    using System.Web.Ria;
    using System.Web.Ria.Services;


    // The MetadataTypeAttribute identifies fls_COMPANY_INFOMetadata as the class
    // that carries additional metadata for the fls_COMPANY_INFO class.
    [MetadataTypeAttribute(typeof(fls_COMPANY_INFO.fls_COMPANY_INFOMetadata))]
    public partial class fls_COMPANY_INFO
    {

        // This class allows you to attach custom attributes to properties
        // of the fls_COMPANY_INFO class.
        //
        // For example, the following marks the Xyz property as a
        // required field and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz;
        internal sealed class fls_COMPANY_INFOMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private fls_COMPANY_INFOMetadata()
            {
            }

            public string Chief_Position;

            public short Comp_Account;

            public string Comp_Address;

            public string Comp_Chief;

            public string Comp_City;

            public string Comp_Cont_Address;

            public string Comp_Cont_city;

            public string Comp_Cont_fax;

            public string Comp_Cont_index;

            public string Comp_Cont_tel;

            public string Comp_Fax;

            public string Comp_Index;

            public string Comp_Mail;

            public string Comp_Name;

            public string Comp_Tel;

            public string Comp_URL;

            public string CONTACT_NAME;

            public EntitySet<fls_LICENCE_INFO> fls_LICENCE_INFOs;

            public Nullable<DateTime> gave;

            public bool HAS_NO_FREQ;

            public int id;

            public bool REC_Form1;

            public Nullable<DateTime> Received;

            public string remark;

            public Nullable<DateTime> SENT;

            public string tax_id;
        }
    }
}

#pragma warning restore 649    // re-enable compiler warnings about unassigned fields
