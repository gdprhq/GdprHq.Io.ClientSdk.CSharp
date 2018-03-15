using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GdprHq.Io.ClientSdk.Rights.Interfaces
{
    /// <summary>
    /// Article 4(4): Definitions
    /// Article 9: Processing of special categories of personal data
    /// Article 12: Transparent information, communication and modalities for the exercise of the rights of the data subject
    /// Article 13: Information to be provided where personal data are collected from the data subject
    /// Article 14: Information to be provided where personal data have not been obtained from the data subject
    /// Article 15: Right of access by the data subject
    /// Article 21: Right to object
    /// Article 22: Automated individual decision-making, including profiling
    /// Article 35(1)(3): Data protection impact assessment
    /// 
    /// The GDPR has provisions on:
    /// - automated individual decision-making (making a decision solely by automated means without any human involvement);and
    /// - profiling (automated processing of personal data to evaluate certain things about an individual). Profiling can be part of an automated decision-making process.
    /// The GDPR applies to all automated individual decision-making and profiling.
    /// Article 22 of the GDPR has additional rules to protect individuals if you are carrying out solely automated decision-making that has legal or similarly significant effects on them.
    /// You can only carry out this type of decision-making where the decision is:
    /// - necessary for the entry into or performance of a contract; or
    /// - authorised by Union or Member state law applicable to the controller; or
    /// - based on the individual’s explicit consent.
    /// You must identify whether any of your processing falls under Article 22 and, if so, make sure that you:
    /// - give individuals information about the processing;
    /// - introduce simple ways for them to request human intervention or challenge a decision;
    /// - carry out regular checks to make sure that your systems are working as intended.
    /// 
    /// 
    /// https://gdpr-info.eu/art-4-gdpr/
    /// https://gdpr-info.eu/art-9-gdpr/
    /// https://gdpr-info.eu/art-12-gdpr/
    /// https://gdpr-info.eu/art-13-gdpr/
    /// https://gdpr-info.eu/art-14-gdpr/
    /// https://gdpr-info.eu/art-15-gdpr/
    /// https://gdpr-info.eu/art-21-gdpr/
    /// https://gdpr-info.eu/art-22-gdpr/
    /// https://gdpr-info.eu/art-35-gdpr/
    /// 
    /// https://ico.org.uk/for-organisations/guide-to-the-general-data-protection-regulation-gdpr/individual-rights/rights-related-to-automated-decision-making-including-profiling/
    /// </summary>
    public interface IProfiling
    {

    }
}
