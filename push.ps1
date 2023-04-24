# GitHub

git add .
git stage .
git commit -am update
git push

# DockerHub

docker build . -t fortunen/fineoperator-csharp-example-01
docker tag fortunen/fineoperator-csharp-example-01 fortunen/fineoperator-csharp-example-01
docker push fortunen/fineoperator-csharp-example-01
docker pushrm fortunen/fineoperator-csharp-example-01 # https://github.com/christian-korneck/docker-pushrm
