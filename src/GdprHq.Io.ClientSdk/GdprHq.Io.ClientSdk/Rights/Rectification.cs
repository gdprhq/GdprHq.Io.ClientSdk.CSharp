using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GdprHq.Io.ClientSdk.Rights
{
    public class Rectification : Interfaces.IRectification
    {
        /// <summary>
        /// Rectify personal data for selected data subject.
        /// </summary>
        /// <param name="dataSubjectIdentifier"></param>
        /// <param name="personalData">Current version of the personal data; this version will replace the old, existing one.</param>
        /// <returns>True if personal data is changed successfuly; otherwise, returns true.</returns>
        public bool RectifyPersonalData(object dataSubjectIdentifier, object personalData)
        {
            throw new NotImplementedException();
        }
    }
}
