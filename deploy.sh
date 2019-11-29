#!/bin/bash

printf "Copying files to remote server..."
rsync -avz -e 'ssh' dist/ deploy@nuc:/home/deploy/apps/backgarden

if [ $? -ne 0 ]
then
  printf "Error copying files!"
  return 1
fi

printf "Files copyied! Starting service"
ssh deploy@nuc "sudo supervisorctl restart backgarden"
