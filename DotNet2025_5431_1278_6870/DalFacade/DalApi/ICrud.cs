namespace DalApi
{
    public interface ICrud<T>
    {
        int Create(T item); //יצירת אוביקט
        T? Read(int id); //חיפוש אוביקט
        List<T?> ReadAll(Func<T,bool>? filter=null); //מחזיר רשימת אוביקטים
        void Update(T item); //מעדכן אוביקט
        void Delete(int id); //מחיקת אוביקט
        T? Read(Func<T,bool>? filter);

    }
}
