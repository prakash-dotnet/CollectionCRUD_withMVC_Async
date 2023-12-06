namespace CollectionCRUD_withMVC_Async.Models
{
    public class ItemRepository
    {
        private readonly List<Item> _items = new List<Item>();
        private int _nextId = 1;

        public async Task<IEnumerable<Item>> GetAllAsync()
        {
            await Task.Delay(100); // Simulate async delay
            return _items;
        }

        public async Task<Item> GetByIdAsync(int id)
        {
            await Task.Delay(100); // Simulate async delay
            return _items.FirstOrDefault(item => item.Id == id);
        }

        public async Task CreateAsync(Item item)
        {
            await Task.Delay(100); // Simulate async delay
            item.Id = _nextId++;
            _items.Add(item);
        }

        public async Task UpdateAsync(Item item)
        {
            await Task.Delay(100); // Simulate async delay
            var existingItem = _items.FirstOrDefault(i => i.Id == item.Id);
            if (existingItem != null)
            {
                existingItem.Name = item.Name;
            }
        }

        public async Task DeleteAsync(int id)
        {
            await Task.Delay(100); // Simulate async delay
            var itemToRemove = _items.FirstOrDefault(i => i.Id == id);
            if (itemToRemove != null)
            {
                _items.Remove(itemToRemove);
            }
        }
    }
}
