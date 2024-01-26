namespace ANC_MVC_BookShoop
{
	public interface IHomeRepository
	{
		Task<IEnumerable<Book>> GetBooks(string sTerm = "", int genreId = 0);
	}
}