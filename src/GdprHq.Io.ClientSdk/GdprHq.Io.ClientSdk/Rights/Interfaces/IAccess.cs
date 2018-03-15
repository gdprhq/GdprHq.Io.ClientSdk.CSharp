using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GdprHq.Io.ClientSdk.Rights.Interfaces
{
    /// <summary>
    /// Article 12: Transparent information, communication and modalities for the exercise of the rights of the data subject
    /// Article 15: Right of access by the data subject
    /// Recital 63: Right of access*
    /// 
    /// Individuals have the right to access their personal data and supplementary information.
    /// The right of access allows individuals to be aware of and verify the lawfulness of the processing.
    /// 
    /// 
    /// https://gdpr-info.eu/art-12-gdpr/
    /// https://gdpr-info.eu/art-15-gdpr/
    /// https://gdpr-info.eu/recitals/no-63/
    /// 
    /// https://ico.org.uk/for-organisations/guide-to-the-general-data-protection-regulation-gdpr/individual-rights/right-of-access/
    /// </summary>
    public interface IAccess
    {
        /// <summary>
        /// Article 15(1): individuals will have the right to obtain confirmation that their data is being processed
        /// </summary>
        /// <param name="dataSubjectIdentifier"></param>
        /// <returns></returns>
        bool IsPersonalDataBeignProcessed(object dataSubjectIdentifier);

        /// <summary>
        /// Article 15(1): individuals will have the right to obtain access to their personal data
        /// Article 15(3): the controller shall provide a copy of the personal data undergoing processing.
        /// </summary>
        /// <remarks>Article 20(1): Returned data should be in a structured, commonly used and machine-readable format</remarks>
        /// <param name="dataSubjectIdentifier"></param>
        /// <returns></returns>
        object GetPersonalData(object dataSubjectIdentifier);

        /// <summary>
        /// Article 15(1)(a): the purposes of the processing
        /// </summary>
        /// <param name="processingIdentifier"></param>
        /// <returns></returns>
        object GetPurposeOfProcessing(object processingIdentifier);

        /// <summary>
        /// Article 15(1)(b): the categories of personal data concerned
        /// </summary>
        /// <param name="processingIdentifier"></param>
        /// <returns></returns>
        object GetCategoriesOfPersonalData(object processingIdentifier);

        /// <summary>
        /// Article 15(1)(c): the recipients or categories of recipient to whom the personal data have been or will be disclosed, in particular recipients in third countries or international organisations
        /// </summary>
        /// <param name="processingIdentifier"></param>
        /// <returns></returns>
        object GetRecipientsOfPersonalData(object processingIdentifier);

        /// <summary>
        /// Article 15(1)(d): where possible, the envisaged period for which the personal data will be stored, or, if not possible, the criteria used to determine that period
        /// </summary>
        /// <param name="dataSubjectIdentifier"></param>
        /// <returns></returns>
        object GetEnvisagedPeriodOfPersonalDataStorage(object dataSubjectIdentifier);

        /// <summary>
        /// Article 15(1)(e): the existence of the right to request from the controller rectification or erasure of personal data or restriction of processing of personal data concerning the data subject or to object to such processing
        /// </summary>
        /// <param name="dataSubjectIdentifier"></param>
        /// <returns></returns>
        object GetExistanceOfApplicableDataSubjectRights(object dataSubjectIdentifier);

        /// <summary>
        /// Article 15(1)(f): the right to lodge a complaint with a supervisory authority
        /// </summary>
        /// <param name="dataSubjectIdentifier"></param>
        /// <returns></returns>
        object GetRightToLodgeCompliant(object dataSubjectIdentifier);

        /// <summary>
        /// Article 15(1)(g): where the personal data are not collected from the data subject, any available information as to their source
        /// </summary>
        /// <param name="dataSubjectIdentifier"></param>
        /// <returns></returns>
        object GetPersonalDataExternalSource(object dataSubjectIdentifier);

        /// <summary>
        /// Article 15(1)(h): the existence of automated decision-making, including profiling, referred to in Article 22(1) and (4) and, at least in those cases, meaningful information about the logic involved, as well as the significance and the envisaged consequences of such processing for the data subject
        /// </summary>
        /// <param name="dataSubjectIdentifier"></param>
        /// <returns></returns>
        object GetPersonalDataProfilingInformation(object dataSubjectIdentifier);
    }
}
