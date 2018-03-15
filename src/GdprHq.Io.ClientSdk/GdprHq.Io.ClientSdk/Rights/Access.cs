using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GdprHq.Io.ClientSdk.Rights
{
    public class Access : Interfaces.IAccess
    {
        /// <summary>
        /// Determine if you're processing personal data for the data subject.
        /// </summary>
        /// <remarks>Go through all the data sources used in this application where personal data is stored. Return true if there is any personal data for the data subject in this application.</remarks>
        /// <param name="dataSubjectIdentifier"></param>
        /// <returns>True if personal data is used in this application, otherwise returns false.</returns>
        public bool IsPersonalDataBeignProcessed(object dataSubjectIdentifier)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get actual personal data processed.
        /// </summary>
        /// <remarks>Go through all the data sources used in this application where personal data is stored. Return actual personal data for the data subject.</remarks>
        /// <remarks>Returned data should be in a structured, commonly used and machine-readable format</remarks>
        /// <example>first name, last name, e-mail, ...</example>
        /// <param name="dataSubjectIdentifier"></param>
        /// <returns>Actual personal data.</returns>
        public object GetPersonalData(object dataSubjectIdentifier)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get purpose of processing activity.
        /// </summary>
        /// <remarks>What's the purpose of the processing of the personal data.</remarks>
        /// <example>Payroll, Personel file, Recruitment, Direct marketing, ...</example>
        /// <param name="processingIdentifier"></param>
        /// <returns>Name of the purpose.</returns>
        public object GetPurposeOfProcessing(object processingIdentifier)
        {
            if (Shared.ApiSettings.IsApiEnabled())
            {
                Shared.ApiCore apiCore = new Shared.ApiCore();
                string json = apiCore.Call(Shared.Enums.ApiMethodEnum.GET, "api/Rights/Access/GetPurposeOfProcessing/" + processingIdentifier, "");
                return json;
            }

            throw new NotImplementedException();
        }

        /// <summary>
        /// Get categories of personal data.
        /// </summary>
        /// <param name="processingIdentifier"></param>
        /// <returns>Categories of personal data.</returns>
        public object GetCategoriesOfPersonalData(object processingIdentifier)
        {
            if (Shared.ApiSettings.IsApiEnabled())
            {
                Shared.ApiCore apiCore = new Shared.ApiCore();
                string json = apiCore.Call(Shared.Enums.ApiMethodEnum.GET, "api/Rights/Access/GetCategoriesOfPersonalData/" + processingIdentifier, "");
                return json;
            }

            throw new NotImplementedException();
        }

        public object GetRecipientsOfPersonalData(object processingIdentifier)
        {
            if (Shared.ApiSettings.IsApiEnabled())
            {
                Shared.ApiCore apiCore = new Shared.ApiCore();
                string json = apiCore.Call(Shared.Enums.ApiMethodEnum.GET, "api/Rights/Access/GetRecipientsOfPersonalData/" + processingIdentifier, "");
                return json;
            }

            throw new NotImplementedException();
        }

        public object GetEnvisagedPeriodOfPersonalDataStorage(object dataSubjectIdentifier)
        {
            throw new NotImplementedException();
        }

        public object GetExistanceOfApplicableDataSubjectRights(object dataSubjectIdentifier)
        {
            throw new NotImplementedException();
        }

        public object GetRightToLodgeCompliant(object dataSubjectIdentifier)
        {
            throw new NotImplementedException();
        }

        public object GetPersonalDataExternalSource(object dataSubjectIdentifier)
        {
            throw new NotImplementedException();
        }

        public object GetPersonalDataProfilingInformation(object dataSubjectIdentifier)
        {
            throw new NotImplementedException();
        }
    }
}
