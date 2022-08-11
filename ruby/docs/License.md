# OpenapiClient::License

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **key** | **String** |  |  |
| **name** | **String** |  |  |
| **spdx_id** | **String** |  |  |
| **url** | **String** |  |  |
| **node_id** | **String** |  |  |
| **html_url** | **String** |  |  |
| **description** | **String** |  |  |
| **implementation** | **String** |  |  |
| **permissions** | **Array&lt;String&gt;** |  |  |
| **conditions** | **Array&lt;String&gt;** |  |  |
| **limitations** | **Array&lt;String&gt;** |  |  |
| **body** | **String** |  |  |
| **featured** | **Boolean** |  |  |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::License.new(
  key: mit,
  name: MIT License,
  spdx_id: MIT,
  url: https://api.github.com/licenses/mit,
  node_id: MDc6TGljZW5zZW1pdA&#x3D;&#x3D;,
  html_url: http://choosealicense.com/licenses/mit/,
  description: A permissive license that is short and to the point. It lets people do anything with your code with proper attribution and without warranty.,
  implementation: Create a text file (typically named LICENSE or LICENSE.txt) in the root of your source code and copy the text of the license into the file. Replace [year] with the current year and [fullname] with the name (or names) of the copyright holders.,
  permissions: [&quot;commercial-use&quot;,&quot;modifications&quot;,&quot;distribution&quot;,&quot;sublicense&quot;,&quot;private-use&quot;],
  conditions: [&quot;include-copyright&quot;],
  limitations: [&quot;no-liability&quot;],
  body: 

The MIT License (MIT)

Copyright (c) [year] [fullname]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the &quot;Software&quot;), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED &quot;AS IS&quot;, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
,
  featured: true
)
```

