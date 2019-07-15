#!/bin/sh
docker run --rm -p 10000:10000 -v $(pwd):/etc/envoy envoyproxy/envoy-alpine:v1.11.0