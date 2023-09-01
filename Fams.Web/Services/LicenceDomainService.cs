
namespace Fams.Web.Services
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Linq;
    using System.Linq;
    using System.Web.DomainServices;
    using System.Web.DomainServices.Providers;
    using System.Web.Ria;
    using System.Web.Ria.Services;
    using Fams.Web;


    // Implements application logic using the FamsDataClassesDataContext context.
    // TODO: Add your application logic to these methods or in additional methods.
    // TODO: Wire up authentication (Windows/ASP.NET Forms) and uncomment the following to disable anonymous access
    // Also consider adding roles to restrict access as appropriate.
    // [RequiresAuthentication]
    [EnableClientAccess()]
    public class LicenceDomainService : LinqToSqlDomainService<FamsDataClassesDataContext>
    {

        // TODO: Consider
        // 1. Adding parameters to this method and constraining returned results, and/or
        // 2. Adding query methods taking different parameters.
        public IQueryable<fls_LICENCE_INFO> GetFls_LICENCE_INFOs()
        {
            return this.DataContext.fls_LICENCE_INFOs;
        }

        public void InsertFls_LICENCE_INFO(fls_LICENCE_INFO fls_LICENCE_INFO)
        {
            this.DataContext.fls_LICENCE_INFOs.InsertOnSubmit(fls_LICENCE_INFO);
        }

        public void UpdateFls_LICENCE_INFO(fls_LICENCE_INFO currentfls_LICENCE_INFO)
        {
            this.DataContext.fls_LICENCE_INFOs.Attach(currentfls_LICENCE_INFO, this.ChangeSet.GetOriginal(currentfls_LICENCE_INFO));
        }

        public void DeleteFls_LICENCE_INFO(fls_LICENCE_INFO fls_LICENCE_INFO)
        {
            this.DataContext.fls_LICENCE_INFOs.Attach(fls_LICENCE_INFO);
            this.DataContext.fls_LICENCE_INFOs.DeleteOnSubmit(fls_LICENCE_INFO);
        }

        public IQueryable<fls_LICENCE_INFO> GetLicencesForCompany(int comp_id)
        {
            return this.DataContext.fls_LICENCE_INFOs
                .Where(licence => licence.comp_id == comp_id);
        }
    }
}


