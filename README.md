# ProjectTracer
Platform to track Software development progress. 

Developed using: 

- Design Patterns: Repository patern, Unit of Work design pattern. 
- Authorization with Password Encryption. 
- Entity Framework
- MS SQL SERVER Database
- Unit-Testing

### Design Patterns: Repository patern, Unit of Work design pattern, MVVM (Model-View-ViewModel) For Windows Form Applications. 

Implementation of Repository patern: [here](ProjectTracer/Repository/RepositoryControl/IRepository.cs)
```c#
public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(string id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        void Add(TEntity entity);
        void AddRange(List<TEntity> entities);
        void Remove(TEntity entity);
        void RemoveRange(List<TEntity> entities);
        bool CheckExistance(TEntity entity); 
    }
```

Implementation of Unit of Work [here](/ProjectTracer/Repository/RepositoryControl/IUnityOfWork.cs)
```c#
public interface IUnityOfWork : IDisposable
    {
        IProjectRepository Project { get; }
        ITaskRepository Task { get; }
        IDocumentRepository Document { get; }
        ITeamRepository Team { get;  }
        IClientRepository Client { get; }
        IDeveloperRepository Developer { get;  } 
        ISeniorRepository Senior  { get;  }
        IAdministratorRepository Administrator { get; }
        int Complete();
    }
```

### Authorization with Password Encryption.
For the implementation used helper class encrypt: [here](/ProjectTracer/Controllers/Helpers/Encrypt.cs)
```c#
internal static class Encrypt
    {

        private const string initVector = "pemgail9uzpgz188";

        private const int keysize = 256;

        public static string EncryptString(string plainText, string passPhrase)
        {

            byte[] initVectorBytes = Encoding.UTF8.GetBytes(initVector);

            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);

            byte[] keyBytes = password.GetBytes(keysize / 8);

            RijndaelManaged symmetricKey = new RijndaelManaged();

            symmetricKey.Mode = CipherMode.CBC;

            ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);

            MemoryStream memoryStream = new MemoryStream();

            CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);

            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);

            cryptoStream.FlushFinalBlock();

            byte[] cipherTextBytes = memoryStream.ToArray();

            memoryStream.Close();

            cryptoStream.Close();

            return Convert.ToBase64String(cipherTextBytes);

        }
      
        public static string DecryptString(string cipherText, string passPhrase)
        {
            byte[] initVectorBytes = Encoding.UTF8.GetBytes(initVector);

            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);

            PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);

            byte[] keyBytes = password.GetBytes(keysize / 8);

            RijndaelManaged symmetricKey = new RijndaelManaged();

            symmetricKey.Mode = CipherMode.CBC;

            ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);

            MemoryStream memoryStream = new MemoryStream(cipherTextBytes);

            CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);

            byte[] plainTextBytes = new byte[cipherTextBytes.Length];

            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);

            memoryStream.Close();

            cryptoStream.Close();

            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);

        }

```
### MVVM (Model-View-ViewModel) For Windows Form Applications

Logic is devided in three main parts: model view view-model :[here](ProjectTracer/)

### Entity Framework
The interaction with the Database was done all through Entity Framework: [here](/ProjectTracer/ProjectTracerDataModel.Context.cs)

### DataBase Done in SQL SERVER
DataBase Diagram with its respective one to many, many to many relationships: [here](/ProjectTracer/DataBaseBuckUp)

### Screenshots of the final product

![](Screenshots/img1.PNG)

![LogInForm](Screenshots/img2.PNG)

![Administrator view](Screenshots/img3.PNG)

![Developer view](Screenshots/img4.PNG)

![Senior developer view](Screenshots/img5.PNG)

![Client view](Screenshots/img6.PNG)
