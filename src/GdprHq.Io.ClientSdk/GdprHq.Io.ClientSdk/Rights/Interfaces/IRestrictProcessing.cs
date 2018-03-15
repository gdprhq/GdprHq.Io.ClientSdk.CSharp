using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GdprHq.Io.ClientSdk.Rights.Interfaces
{
    /// <summary>
    /// Article 18: Right to restriction of processing
    /// Article 19: Notification obligation regarding rectification or erasure of personal data or restriction of processing
    /// Recital 67: Restriction of processing*
    /// 
    /// Individuals have a right to ‘block’ or suppress processing of personal data.
    /// When processing is restricted, you are permitted to store the personal data, but not further process it.
    /// You can retain just enough information about the individual to ensure that the restriction is respected in future.
    /// 
    /// 
    /// https://gdpr-info.eu/art-18-gdpr/
    /// https://gdpr-info.eu/art-19-gdpr/
    /// https://gdpr-info.eu/recitals/no-67/
    /// 
    /// https://ico.org.uk/for-organisations/guide-to-the-general-data-protection-regulation-gdpr/individual-rights/right-to-restrict-processing/
    /// </summary>
    public interface IRestrictProcessing
    {
        /// <summary> ***
        /// Article 18(1): The data subject shall have the right to obtain from the controller restriction of processing 
        /// </summary>
        /// <param name="dataSubjectIdentifier"></param>
        /// <param name="processingIdentifier"></param>
        /// <returns></returns>
        void RestrictProcessingOfPersonalData(object dataSubjectIdentifier, object processingIdentifier);

        /// <summary>
        /// Article 18(1): The data subject shall have the right to obtain from the controller restriction of processing 
        /// </summary>
        /// <param name="dataSubjectIdentifier"></param>
        /// <param name="processingIdentifier"></param>
        /// <returns>True if processing of the personal data is restricted.</returns>
        bool IsPersonalDataProcessingRestricted(object dataSubjectIdentifier, object processingIdentifier);

        /// <summary>
        /// Article 19: The controller shall communicate any rectification or erasure of personal data or restriction of processing carried out in accordance with Article 16, Article 17(1) and Article 18 to each recipient to whom the personal data have been disclosed
        /// </summary>
        /// <param name="dataSubjectIdentifier"></param>
        /// <param name="dataRecipient"></param>
        /// <param name="processingIdentifier"></param>
        /// <returns>True if successfull.</returns>
        bool InformDataRecipientOfRestrictProcessingRequest(object dataSubjectIdentifier, object dataRecipient, object processingIdentifier);

        /// <summary>
        /// Article 18(3): A data subject who has obtained restriction of processing pursuant to paragraph 1 shall be informed by the controller before the restriction of processing is lifted.
        /// </summary>
        /// <param name="dataSubjectIdentifier"></param>
        /// <param name="processingIdentifier"></param>
        /// <returns>True if successfull.</returns>
        bool InformDataSubjectOfDecisionToLiftRestrictionOnProcessing(object dataSubjectIdentifier, object processingIdentifier);
    }
}
