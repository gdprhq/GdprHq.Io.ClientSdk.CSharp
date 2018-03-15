using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GdprHq.Io.ClientSdk.Rights.Interfaces
{
    /// <summary>
    /// Article 12: Transparent information, communication and modalities for the exercise of the rights of the data subject
    /// Article 16: Right to rectification
    /// Article 19: Notification obligation regarding rectification or erasure of personal data or restriction of processing
    /// Recital 65: Right of rectification and erasure*
    /// 
    /// Individuals are entitled to have personal data rectified if it is inaccurate or incomplete.
    /// 
    /// 
    /// https://gdpr-info.eu/art-12-gdpr/
    /// https://gdpr-info.eu/art-16-gdpr/
    /// https://gdpr-info.eu/art-19-gdpr/
    /// https://gdpr-info.eu/recitals/no-65/
    /// 
    /// https://ico.org.uk/for-organisations/guide-to-the-general-data-protection-regulation-gdpr/individual-rights/right-to-rectification/
    /// </summary>
    public interface IRectification
    {
        /// <summary>
        /// Article 16: The data subject shall have the right to obtain from the controller without undue delay the rectification of inaccurate personal data concerning him or her
        /// </summary>
        /// <param name="dataSubjectIdentifier"></param>
        /// <param name="personalData">Current version of the personal data; this version will replace the old, existing one.</param>
        /// <returns>True if personal data is changed successfuly; otherwise, returns true.</returns>
        bool RectifyPersonalData(object dataSubjectIdentifier, object personalData);
    }
}
