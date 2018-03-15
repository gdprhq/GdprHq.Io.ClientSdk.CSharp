using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GdprHq.Io.ClientSdk.Rights
{
    public class Object : Interfaces.IObject
    {
        /// <summary>
        /// Receive and save objection of further personal data processing.
        /// </summary>
        /// <param name="dataSubjectIdentifier"></param>
        /// <param name="processingIdentifier"></param>
        public void ObjectToProcessingOfPersonalData(object dataSubjectIdentifier, object processingIdentifier)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Check if data subject objected to specified personal data processing.
        /// </summary>
        /// <param name="dataSubjectIdentifier"></param>
        /// <param name="processingIdentifier"></param>
        /// <returns>True if data subject objected to processing of personal data for particular processing.</returns>
        public bool IsDataSubjectObjectedToProcessing(object dataSubjectIdentifier, object processingIdentifier)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get info about the right to object for specified processing.
        /// </summary>
        /// <param name="processingIdentifier"></param>
        /// <returns>Information about the right to object to specified processing.</returns>
        public object GetRightToObjectInformation(object processingIdentifier)
        {
            throw new NotImplementedException();
        }
    }
}
