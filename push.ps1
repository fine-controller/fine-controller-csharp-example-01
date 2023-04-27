# GitHub

git add .
git stage .
git commit -am update
git push

# DockerHub

docker build . -t fortunen/fine-kube-operator-csharp-example
docker tag fortunen/fine-kube-operator-csharp-example fortunen/fine-kube-operator-csharp-example
docker push fortunen/fine-kube-operator-csharp-example
docker pushrm fortunen/fine-kube-operator-csharp-example # https://github.com/christian-korneck/docker-pushrm
