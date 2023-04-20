# GitHub

git add .
git stage .
git commit -am update
git push

# DockerHub

docker build . -t fortunen/finecontroller-csharp-example-01
docker tag fortunen/finecontroller-csharp-example-01 fortunen/finecontroller-csharp-example-01
docker push fortunen/finecontroller-csharp-example-01
docker pushrm fortunen/finecontroller-csharp-example-01 # https://github.com/christian-korneck/docker-pushrm
