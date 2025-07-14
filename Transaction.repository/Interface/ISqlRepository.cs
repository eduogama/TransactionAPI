namespace Transaction.repository.Interface
{
    public interface ISqlRepository
    {
        public List<T> GetAll<T>(string command, object parms);
        public T GetById<T>(string command, string id);
        public int Insert(string command, object parms);
        public int Update(string command, object parms);
        public int Delete(string command, string id);
    }
}
