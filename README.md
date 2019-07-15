Steps to reproduce:

1. In `server`: `dotnet run`
2. In `envoy`: `docker run --rm -p 10000:10000 -v $(pwd):/etc/envoy envoyproxy/envoy-alpine:v1.11.0`
3. In `client`: `dotnet run`

