using VoiceOfTheCity.Models;

namespace VoiceOfTheCity.Repositories {

    public interface IReportRepository: IRepository<Report> {

        Task<IEnumerable<Report>> GetReportsByCategoryAsync(string category);
    }
}