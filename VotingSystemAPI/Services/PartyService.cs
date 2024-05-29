using System.Collections.Generic;
using VotingSystemAPI.Models;

namespace VotingSystemAPI.Services
{
    public class PartyService
    {
        public IEnumerable<string> GetParties()
        {
            var parties = new List<string>
            {
                Votingenum.Parties.MK.ToString(),
                Votingenum.Parties.DA.ToString(),
                Votingenum.Parties.EFF.ToString(),
                Votingenum.Parties.MKP.ToString(),
                Votingenum.Parties.IFP.ToString(),
                Votingenum.Parties.ActionSA.ToString(),
                Votingenum.Parties.FF.ToString(),
                Votingenum.Parties.Other.ToString()
            };

            return parties;
        }

        public IEnumerable<Votingenum.Parties> GetPartiesByBallotType(string ballotType)
        {
            var parties = new List<Votingenum.Parties>();

            if (ballotType == "NationalCompensatoryBallot")
            {
                parties.Add(Votingenum.Parties.EFF);
                parties.Add(Votingenum.Parties.DA);
            }
            else if (ballotType == "NationalRegionalBallot")
            {
                parties.Add(Votingenum.Parties.EFF);
                parties.Add(Votingenum.Parties.MKP);
            }

            return parties;
        }
    }
}