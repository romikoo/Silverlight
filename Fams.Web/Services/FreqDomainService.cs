
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
    public class FreqDomainService : LinqToSqlDomainService<FamsDataClassesDataContext>
    {

        // TODO: Consider
        // 1. Adding parameters to this method and constraining returned results, and/or
        // 2. Adding query methods taking different parameters.
        public IQueryable<Fams_Freq> GetFams_Freqs()
        {
            return this.DataContext.Fams_Freqs;
        }

        public void InsertFams_Freq(Fams_Freq fams_Freq)
        {
            this.DataContext.Fams_Freqs.InsertOnSubmit(fams_Freq);
        }

        public void UpdateFams_Freq(Fams_Freq currentFams_Freq)
        {
            this.DataContext.Fams_Freqs.Attach(currentFams_Freq, this.ChangeSet.GetOriginal(currentFams_Freq));
        }

        public void DeleteFams_Freq(Fams_Freq fams_Freq)
        {
            this.DataContext.Fams_Freqs.Attach(fams_Freq);
            this.DataContext.Fams_Freqs.DeleteOnSubmit(fams_Freq);
        }

        public IQueryable<Fams_Freq> GetFrequenciesForLicence(int licence_id)
        {
            return this.DataContext.Fams_Freqs
                .Where(freq => freq.licence_id == licence_id);
        }
    }
}


