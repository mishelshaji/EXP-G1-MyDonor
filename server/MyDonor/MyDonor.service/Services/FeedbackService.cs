using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDonor.service.Services
{
    public class FeedbackService
    {
        private readonly ApplicationDbContext _db;

        public FeedbackService(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse<FeedbackViewDto>> FeedbackAsync(string id, FeedbackCreateDto dto)
        {
            var Response = new ServiceResponse<FeedbackViewDto>();
            var user = await _db.ApplicationUsers.FindAsync(id);
            if (user == null)
            {
                Response.AddError("user", "user does not exist");
                return Response;
            }
            var feedback = new Feedback
            {
                ApplicationUserId = id,
                Content = dto.Content,
            };
            _db.Feedbacks.Add(feedback);
            await _db.SaveChangesAsync();

            Response.Result = new FeedbackViewDto
            {
                Id = feedback.Id,
                Content = feedback.Content
            };
            return Response;
        }
    }
}
