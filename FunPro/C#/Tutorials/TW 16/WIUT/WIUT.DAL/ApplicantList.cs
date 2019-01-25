using System.Collections.Generic;

namespace WIUT.DAL
{
    public class ApplicantList
    {
        public List<Applicant> GetAllaApplicants()
        {
            return new ApplicantManager().GetAll();
        }
    }
}
