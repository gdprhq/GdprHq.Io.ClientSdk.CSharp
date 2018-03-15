using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GdprHq.Io.ClientSdk.Rights
{
    public class RestrictProcessing : Interfaces.IRestrictProcessing
    {
        /// <summary>
        /// Receive and save processing restriction of personal data for data subject and processing.
        /// </summary>
        /// <param name="dataSubjectIdentifier"></param>
        /// <param name="processingIdentifier"></param>
        public void RestrictProcessingOfPersonalData(object dataSubjectIdentifier, object processingIdentifier)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Check if there is processing restrictions for data subject and processing.
        /// </summary>
        /// <param name="dataSubjectIdentifier"></param>
        /// <param name="processingIdentifier"></param>
        /// <returns>True if processing of the personal data is restricted.</returns>
        public bool IsPersonalDataProcessingRestricted(object dataSubjectIdentifier, object processingIdentifier)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Inform data recipient to whom the personal data have been disclosed about processing restriction.
        /// </summary>
        /// <param name="dataSubjectIdentifier"></param>
        /// <param name="dataRecipient"></param>
        /// <param name="processingIdentifier"></param>
        /// <returns>True if successfull.</returns>
        public bool InformDataRecipientOfRestrictProcessingRequest(object dataSubjectIdentifier, object dataRecipient, object processingIdentifier)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Inform data subject before the restriction of processing is lifted.
        /// </summary>
        /// <param name="dataSubjectIdentifier"></param>
        /// <param name="processingIdentifier"></param>
        /// <returns>True if successfull.</returns>
        public bool InformDataSubjectOfDecisionToLiftRestrictionOnProcessing(object dataSubjectIdentifier, object processingIdentifier)
        {
            throw new NotImplementedException();
        }
    }
}
