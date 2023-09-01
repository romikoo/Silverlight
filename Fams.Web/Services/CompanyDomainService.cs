
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
    public class CompanyDomainService : LinqToSqlDomainService<FamsDataClassesDataContext>
    {

        // TODO: Consider
        // 1. Adding parameters to this method and constraining returned results, and/or
        // 2. Adding query methods taking different parameters.
        public IQueryable<fls_COMPANY_INFO> GetFls_COMPANY_INFOs()
        {
            return this.DataContext.fls_COMPANY_INFOs;
        }

        public void InsertFls_COMPANY_INFO(fls_COMPANY_INFO fls_COMPANY_INFO)
        {
            this.DataContext.fls_COMPANY_INFOs.InsertOnSubmit(fls_COMPANY_INFO);
        }

        public void UpdateFls_COMPANY_INFO(fls_COMPANY_INFO currentfls_COMPANY_INFO)
        {
            this.DataContext.fls_COMPANY_INFOs.Attach(currentfls_COMPANY_INFO, this.ChangeSet.GetOriginal(currentfls_COMPANY_INFO));
        }

        public void DeleteFls_COMPANY_INFO(fls_COMPANY_INFO fls_COMPANY_INFO)
        {
            this.DataContext.fls_COMPANY_INFOs.Attach(fls_COMPANY_INFO);
            this.DataContext.fls_COMPANY_INFOs.DeleteOnSubmit(fls_COMPANY_INFO);
        }

    }
}


