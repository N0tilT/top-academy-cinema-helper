using CinemaHelper.Core.Utility;
using System.Net.Http.Headers;
using System.Net.Http.Json;


namespace CinemaHelper.Core.Data
{
    public class CinemaRemoteDataSource
    {
        public static readonly HttpClient client = new HttpClient();

        public CinemaRemoteDataSource()
        {
            client.BaseAddress = new Uri("http://localhost:5118/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public async Task<Cinema> GetCinemaAsync(string path)
        {
            Cinema cinema = null;

            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                cinema = DataSerializer.Deserialize<Cinema>(
                    await response.Content.ReadAsStringAsync());
            }
            return cinema;
        }

        public async Task<List<Cinema>> GetSong()
        {

            HttpResponseMessage response = await client.GetAsync(
                "api/Songs");
            response.EnsureSuccessStatusCode();

            List<Cinema> SongResponse = new List<Cinema>();
            if (response.IsSuccessStatusCode)
            {
                SongResponse = DataSerializer.Deserialize<List<Cinema>>(await response.Content.ReadAsStringAsync());
            }
            return SongResponse;
        }

        public async Task<int> PostSong(Cinema song)
        {

            HttpResponseMessage response = await client.PostAsync(
                "api/Songs", JsonContent.Create(song));
            response.EnsureSuccessStatusCode();

            int SongResponse = 0;
            if (response.IsSuccessStatusCode)
            {
                SongResponse = DataSerializer.Deserialize<int>(await response.Content.ReadAsStringAsync());
            }
            return SongResponse;
        }

    }
}
