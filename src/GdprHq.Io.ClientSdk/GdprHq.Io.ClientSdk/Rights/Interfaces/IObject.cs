using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GdprHq.Io.ClientSdk.Rights.Interfaces
{
    /// <summary>
    /// Article 12: Transparent information, communication and modalities for the exercise of the rights of the data subject
    /// Article 21: Right to object
    /// Recital 69: Right to object*
    /// Recital 70: Right to object to direct marketing*
    /// 
    /// Individuals have the right to object to:
    /// - processing based on legitimate interests or the performance of a task in the public interest/exercise of official authority (including profiling);
    /// - direct marketing (including profiling); and
    /// - processing for purposes of scientific/historical research and statistics.
    /// 
    /// 
    /// https://gdpr-info.eu/art-12-gdpr/
    /// https://gdpr-info.eu/art-21-gdpr/
    /// https://gdpr-info.eu/recitals/no-69/
    /// https://gdpr-info.eu/recitals/no-70/
    /// 
    /// https://ico.org.uk/for-organisations/guide-to-the-general-data-protection-regulation-gdpr/individual-rights/right-to-object/
    /// </summary>
    public interface IObject
    {
        /// <summary> ***
        /// Article 21(1): The data subject shall have the right to object, on grounds relating to his or her particular situation, at any time to processing of personal data concerning him or her
        /// </summary>
        /// <param name="dataSubjectIdentifier"></param>
        /// <param name="processingIdentifier"></param>
        void ObjectToProcessingOfPersonalData(object dataSubjectIdentifier, object processingIdentifier);

        /// <summary> ***
        /// 
        /// </summary>
        /// <param name="dataSubjectIdentifier"></param>
        /// <param name="processingIdentifier"></param>
        /// <returns>True if data subject objected to processing of personal data for particular processing.</returns>
        bool IsDataSubjectObjectedToProcessing(object dataSubjectIdentifier, object processingIdentifier);

        /// <summary>
        /// Article 21(4): the right referred to in paragraphs 1 and 2 shall be explicitly brought to the attention of the data subject
        /// </summary>
        /// <param name="processingIdentifier"></param>
        /// <returns>Information about the right to object to specified processing.</returns>
        object GetRightToObjectInformation(object processingIdentifier);


    }
}
