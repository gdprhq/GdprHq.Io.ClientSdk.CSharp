using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GdprHq.Io.ClientSdk.Rights.Interfaces
{
    /// <summary>
    /// Article 12: Transparent information, communication and modalities for the exercise of the rights of the data subject
    /// Article 20: Right to data portability
    /// Recital 68: Right of data portability*
    /// 
    /// The right to data portability allows individuals to obtain and reuse their personal data for their own purposes across different services.
    /// It allows them to move, copy or transfer personal data easily from one IT environment to another in a safe and secure way, without hindrance to usability.
    /// It enables consumers to take advantage of applications and services which can use this data to find them a better deal, or help them understand their spending habits.
    /// 
    /// 
    /// https://gdpr-info.eu/art-12-gdpr/
    /// https://gdpr-info.eu/art-20-gdpr/
    /// https://gdpr-info.eu/recitals/no-68/
    /// 
    /// https://ico.org.uk/for-organisations/guide-to-the-general-data-protection-regulation-gdpr/individual-rights/right-to-data-portability/
    /// </summary>
    public interface IDataPortability
    {
        /// <summary>
        /// Article 20(1): The data subject shall have the right to receive the personal data concerning him or her, which he or she has provided to a controller, in a structured, commonly used and machine-readable format
        /// </summary>
        /// <remarks>To get personal data for the data subject, see the implementation of IAccess.GetPersonalData.</remarks>
        /// <param name="dataSubjectIdentifier"></param>
        /// <param name="personalData"></param>
        /// <returns>True if personal data is successfully delivered to the data subject; otherwise, returns false.</returns>
        bool SendPersonalData(object dataSubjectIdentifier, object personalData);

        /// <summary>
        /// Article 20(2): the data subject shall have the right to have the personal data transmitted directly from one controller to another
        /// </summary>
        /// <param name="dataSubjectIdentifier"></param>
        /// <param name="personalData"></param>
        /// <param name="controllerIdentifier"></param>
        /// <returns>True if personal data is successfully transmitted to another controller.</returns>
        bool TransmitPersonalDataToController(object dataSubjectIdentifier, object personalData, object controllerIdentifier);
    }
}
