namespace GalloTube.Interfaces;

public interface IRepository<T> where T : class
{
    // CRUD: CREATE, READ, UPADTE, DELETE 
    // 4 Operações básicas de todo banco de dados
    void Create(T model); // Add 

    List<T> ReadAll(); // Get 

    T ReadById(int? id); // Get(id)

    void Update(T model); //Edit

    void Delete(int? id);
}