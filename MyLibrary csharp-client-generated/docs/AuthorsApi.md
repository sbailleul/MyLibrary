# IO.Swagger.Api.AuthorsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVversionAuthorsAuthorIdGet**](AuthorsApi.md#apivversionauthorsauthoridget) | **GET** /api/v{version}/authors/{authorId} | Get an author by her/his id
[**ApiVversionAuthorsAuthorIdPatch**](AuthorsApi.md#apivversionauthorsauthoridpatch) | **PATCH** /api/v{version}/authors/{authorId} | Partially update and author
[**ApiVversionAuthorsAuthorIdPut**](AuthorsApi.md#apivversionauthorsauthoridput) | **PUT** /api/v{version}/authors/{authorId} | 
[**ApiVversionAuthorsGet**](AuthorsApi.md#apivversionauthorsget) | **GET** /api/v{version}/authors | 

<a name="apivversionauthorsauthoridget"></a>
# **ApiVversionAuthorsAuthorIdGet**
> Author ApiVversionAuthorsAuthorIdGet (Guid? authorId, string version)

Get an author by her/his id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVversionAuthorsAuthorIdGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AuthorsApi();
            var authorId = new Guid?(); // Guid? | The id of the author you want to get
            var version = version_example;  // string | 

            try
            {
                // Get an author by her/his id
                Author result = apiInstance.ApiVversionAuthorsAuthorIdGet(authorId, version);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorsApi.ApiVversionAuthorsAuthorIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorId** | [**Guid?**](Guid?.md)| The id of the author you want to get | 
 **version** | **string**|  | 

### Return type

[**Author**](Author.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivversionauthorsauthoridpatch"></a>
# **ApiVversionAuthorsAuthorIdPatch**
> Author ApiVversionAuthorsAuthorIdPatch (Guid? authorId, string version, List<Operation> body = null)

Partially update and author

Sample request (this request update the author's **first name**)   ```json  PATCH /authors/id  [       {           \"op\": \"replace\",           \"path\": \"/firstname\",           \"value\": \"new first name\"       }   ]

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVversionAuthorsAuthorIdPatchExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AuthorsApi();
            var authorId = new Guid?(); // Guid? | The id of the author you want to update
            var version = version_example;  // string | 
            var body = new List<Operation>(); // List<Operation> | The set of operations to apply to author (optional) 

            try
            {
                // Partially update and author
                Author result = apiInstance.ApiVversionAuthorsAuthorIdPatch(authorId, version, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorsApi.ApiVversionAuthorsAuthorIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorId** | [**Guid?**](Guid?.md)| The id of the author you want to update | 
 **version** | **string**|  | 
 **body** | [**List&lt;Operation&gt;**](Operation.md)| The set of operations to apply to author | [optional] 

### Return type

[**Author**](Author.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivversionauthorsauthoridput"></a>
# **ApiVversionAuthorsAuthorIdPut**
> Author ApiVversionAuthorsAuthorIdPut (Guid? authorId, string version, AuthorForUpdate body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVversionAuthorsAuthorIdPutExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AuthorsApi();
            var authorId = new Guid?(); // Guid? | 
            var version = version_example;  // string | 
            var body = new AuthorForUpdate(); // AuthorForUpdate |  (optional) 

            try
            {
                Author result = apiInstance.ApiVversionAuthorsAuthorIdPut(authorId, version, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorsApi.ApiVversionAuthorsAuthorIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorId** | [**Guid?**](Guid?.md)|  | 
 **version** | **string**|  | 
 **body** | [**AuthorForUpdate**](AuthorForUpdate.md)|  | [optional] 

### Return type

[**Author**](Author.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json, application/xml, text/xml, application/_*+xml
 - **Accept**: text/plain, application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivversionauthorsget"></a>
# **ApiVversionAuthorsGet**
> List<Author> ApiVversionAuthorsGet (string version)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVversionAuthorsGetExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AuthorsApi();
            var version = version_example;  // string | 

            try
            {
                List&lt;Author&gt; result = apiInstance.ApiVversionAuthorsGet(version);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorsApi.ApiVversionAuthorsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**|  | 

### Return type

[**List<Author>**](Author.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
