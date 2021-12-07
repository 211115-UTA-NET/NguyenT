#!/usr/bin/bash

# shortened designated filepath for easier use
filepath=./loopresult/loopfile.txt

mkdir ./loopresult
touch $filepath
echo "Results from makeloopfile.sh file" > $filepath
for i in {1..20..2}; do
	echo $i >> $filepath
done
echo ""
for i in {2..20..2}; do
    echo -n $i >> $filepath
	if [ $i -lt 20 ]; then
		echo -n ", " >> $filepath
	fi
done
