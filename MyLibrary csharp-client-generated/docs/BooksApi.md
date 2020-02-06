# IO.Swagger.Api.BooksApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVversionAuthorsAuthorIdBooksGet**](BooksApi.md#apivversionauthorsauthoridbooksget) | **GET** /api/v{version}/authors/{authorId}/books | Get the books for a specific author
[**CreateBook**](BooksApi.md#createbook) | **POST** /api/v{version}/authors/{authorId}/books | Create a book for a specific author
[**GetBook**](BooksApi.md#getbook) | **GET** /api/v{version}/authors/{authorId}/books/{bookId} | Get a book by id for a specific author

<a name="apivversionauthorsauthoridbooksget"></a>
# **ApiVversionAuthorsAuthorIdBooksGet**
> List<Book> ApiVversionAuthorsAuthorIdBooksGet (Guid? authorId, string version)

Get the books for a specific author

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVversionAuthorsAuthorIdBooksGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new BooksApi();
            var authorId = new Guid?(); // Guid? | The id of the author
            var version = version_example;  // string | 

            try
            {
                // Get the books for a specific author
                List&lt;Book&gt; result = apiInstance.ApiVversionAuthorsAuthorIdBooksGet(authorId, version);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BooksApi.ApiVversionAuthorsAuthorIdBooksGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorId** | [**Guid?**](Guid?.md)| The id of the author | 
 **version** | **string**|  | 

### Return type

[**List<Book>**](Book.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createbook"></a>
# **CreateBook**
> Book CreateBook (Guid? authorId, string version, BookForCreation body = null)

Create a book for a specific author

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateBookExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new BooksApi();
            var authorId = new Guid?(); // Guid? | The id of the author
            var version = version_example;  // string | 
            var body = new BookForCreation(); // BookForCreation | The book to create (optional) 

            try
            {
                // Create a book for a specific author
                Book result = apiInstance.CreateBook(authorId, version, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BooksApi.CreateBook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorId** | [**Guid?**](Guid?.md)| The id of the author | 
 **version** | **string**|  | 
 **body** | [**BookForCreation**](BookForCreation.md)| The book to create | [optional] 

### Return type

[**Book**](Book.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, application/vnd.martin.bookforcreation+json, application/vnd.martin.bookforcreationwithamountofpages+json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getbook"></a>
# **GetBook**
> Book GetBook (Guid? authorId, Guid? bookId, string version)

Get a book by id for a specific author

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetBookExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new BooksApi();
            var authorId = new Guid?(); // Guid? | The id of the book author
            var bookId = new Guid?(); // Guid? | The id of the book
            var version = version_example;  // string | 

            try
            {
                // Get a book by id for a specific author
                Book result = apiInstance.GetBook(authorId, bookId, version);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BooksApi.GetBook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorId** | [**Guid?**](Guid?.md)| The id of the book author | 
 **bookId** | [**Guid?**](Guid?.md)| The id of the book | 
 **version** | **string**|  | 

### Return type

[**Book**](Book.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.marvin.book+json, application/json, application/xml, application/vnd.marvin.bookwithconcatenatedauthorname+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
