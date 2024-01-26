﻿namespace ANC_MVC_BookShoop
{
	public interface ICartRepository
	{
		Task<bool> AddItem(int bookId, int quantity);
		Task<bool> RemoveItem(int bookId);
		Task<IEnumerable<ShoppingCart>> GetUserCart();
	}
}