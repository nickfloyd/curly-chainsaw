# curly-chainsaw
OpenAPI SDK generation via openapi-generator


### dotnet generation

openapi-generator generate -i https://raw.githubusercontent.com/github/rest-api-description/main/descriptions/api.github.com/dereferenced/api.github.com.deref.json -g csharp-dotnet2 -o [OUTPUT_PATH]

### Ruby generation

openapi-generator generate -i https://raw.githubusercontent.com/github/rest-api-description/main/descriptions/api.github.com/dereferenced/api.github.com.deref.json -g ruby -o [OUTPUT_PATH]

### JavaScript generation

openapi-generator generate -i https://raw.githubusercontent.com/github/rest-api-description/main/descriptions/api.github.com/dereferenced/api.github.com.deref.json -g typescript-node -o [OUTPUT_PATH]


### Setup openapi-generator

`brew install openapi-generator`

Source: [homebrew}(https://formulae.brew.sh/formula/openapi-generator) | [openapi-generator mans page](https://openapi-generator.tech/docs/installation/)

---- 

Generation options available:

ada  
ada-server  
android  
apache2  
apex  
asciidoc  
aspnetcore  
avro-schema  
bash  
crystal  
c  
clojure  
cwiki  
cpp-qt-client  
cpp-qt-qhttpengine-server  
cpp-pistache-server  
cpp-restbed-server  
cpp-restsdk  
cpp-tiny  
cpp-tizen  
cpp-ue4  
csharp  
csharp-netcore  
csharp-dotnet2  
csharp-netcore-functions  
dart  
dart-dio  
eiffel  
elixir  
elm  
erlang-client  
erlang-proper  
erlang-server  
fsharp-functions  
fsharp-giraffe-server  
go  
go-echo-server  
go-server  
go-gin-server  
graphql-schema  
graphql-nodejs-express-server  
groovy  
kotlin  
kotlin-server  
kotlin-spring  
kotlin-vertx  
ktorm-schema  
haskell-http-client  
haskell  
haskell-yesod  
java  
jaxrs-cxf-client  
java-inflector  
java-micronaut-client  
java-micronaut-server  
java-msf4j  
java-pkmst  
java-play-framework  
java-undertow-server  
java-vertx  
java-vertx-web  
java-camel  
jaxrs-cxf  
jaxrs-cxf-extended  
jaxrs-cxf-cdi  
jaxrs-jersey  
jaxrs-resteasy  
jaxrs-resteasy-eap  
jaxrs-spec  
javascript  
javascript-apollo  
javascript-flowtyped  
javascript-closure-angular  
jmeter  
k6  
lua  
markdown  
mysql-schema  
nim  
nodejs-express-server  
objc  
ocaml  
openapi  
openapi-yaml  
plantuml  
perl  
php  
php-laravel  
php-lumen  
php-slim-deprecated  
php-slim4  
php-symfony  
php-mezzio-ph  
php-dt  
powershell  
protobuf-schema  
python-legacy  
python  
python-fastapi  
python-experimental  
python-flask  
python-aiohttp  
python-blueplanet  
r  
ruby  
ruby-on-rails  
ruby-sinatra  
rust  
rust-server  
scalatra  
scala-akka  
scala-akka-http-server  
scala-finch  
scala-httpclient-deprecated  
scala-gatling  
scala-lagom-server  
scala-play-server  
scala-sttp  
scalaz  
spring  
dynamic-html  
html  
html2  
swift5  
typescript  
typescript-angular  
typescript-aurelia  
typescript-axios  
typescript-fetch  
typescript-inversify  
typescript-jquery  
typescript-nestjs  
typescript-node  
typescript-redux-query  
typescript-rxjs  
wsdl-schema  