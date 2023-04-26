# GitHub

git add .
git stage .
git commit -am update
git push

# DockerHub

docker build . -t fortunen/fine-kube-operator-csharp-example-01
docker tag fortunen/fine-kube-operator-csharp-example-01 fortunen/fine-kube-operator-csharp-example-01
docker push fortunen/fine-kube-operator-csharp-example-01
docker pushrm fortunen/fine-kube-operator-csharp-example-01 # https://github.com/christian-korneck/docker-pushrm
