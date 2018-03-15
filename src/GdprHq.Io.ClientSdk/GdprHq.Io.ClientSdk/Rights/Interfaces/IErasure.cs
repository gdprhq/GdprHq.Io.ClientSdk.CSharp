using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GdprHq.Io.ClientSdk.Rights.Interfaces
{
    /// <summary>
    /// Article 17: Right to erasure (‘right to be forgotten’)
    /// Article 19: Notification obligation regarding rectification or erasure of personal data or restriction of processing
    /// Recital 65: Right of rectification and erasure*
    /// Recital 66: Right to be forgotten*
    /// 
    /// The right to erasure is also known as ‘the right to be forgotten’.
    /// The broad principle underpinning this right is to enable an individual to request the deletion or removal of personal data where there is no compelling reason for its continued processing.
    /// 
    /// 
    /// https://gdpr-info.eu/art-17-gdpr/
    /// https://gdpr-info.eu/art-19-gdpr/
    /// https://gdpr-info.eu/recitals/no-65/
    /// https://gdpr-info.eu/recitals/no-66/
    /// 
    /// https://ico.org.uk/for-organisations/guide-to-the-general-data-protection-regulation-gdpr/individual-rights/right-to-erasure/
    /// </summary>
    public interface IErasure
    {
        /// <summary>
        /// Article 17(1): The data subject shall have the right to obtain from the controller the erasure of personal data concerning him or her without undue delay
        /// </summary>
        /// <param name="dataSubjectIdentifier"></param>
        /// <returns>True if the personal data is successfully deleted; otherwise, returns false.</returns>
        bool ErasePersonalData(object dataSubjectIdentifier);

        /// <summary>
        /// Article 17(2): to inform controllers which are processing the personal data that the data subject has requested the erasure by such controllers of any links to, or copy or replication of, those personal data
        /// Article 19: The controller shall communicate any rectification or erasure of personal data or restriction of processing carried out in accordance with Article 16, Article 17(1) and Article 18 to each recipient to whom the personal data have been disclosed
        /// </summary>
        /// <param name="dataSubjectIdentifier"></param>
        /// <param name="dataRecipients"></param>
        /// <returns></returns>
        bool InformDataRecipientsOfErasureRequest(object dataSubjectIdentifier, object dataRecipients);
    }
}
