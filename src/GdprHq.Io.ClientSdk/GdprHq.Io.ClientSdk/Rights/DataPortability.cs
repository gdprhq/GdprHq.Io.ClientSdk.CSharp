using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GdprHq.Io.ClientSdk.Rights
{
    public class DataPortability : Interfaces.IDataPortability
    {
        /// <summary>
        /// Send personal data to the data subject.
        /// </summary>
        /// <param name="dataSubjectIdentifier"></param>
        /// <param name="personalData"></param>
        /// <returns>True if sent successfully.</returns>
        public bool SendPersonalData(object dataSubjectIdentifier, object personalData)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Transmit personal data from you to other controller.
        /// </summary>
        /// <param name="dataSubjectIdentifier"></param>
        /// <param name="personalData"></param>
        /// <param name="controllerIdentifier"></param>
        /// <returns>True if transmission is successfull.</returns>
        public bool TransmitPersonalDataToController(object dataSubjectIdentifier, object personalData, object controllerIdentifier)
        {
            throw new NotImplementedException();
        }
    }
}
