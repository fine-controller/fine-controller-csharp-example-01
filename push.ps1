# GitHub

git add .
git stage .
git commit -am update
git push

# DockerHub

docker build . -t fortunen/fine-controller-example-01
docker tag fortunen/fine-controller-example-01 fortunen/fine-controller-example-01
docker push fortunen/fine-controller-example-01
docker pushrm fortunen/fine-controller-example-01 # https://github.com/christian-korneck/docker-pushrm
