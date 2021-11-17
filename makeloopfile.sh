#!/usr/bin/bash

mkdir ./loopresult
touch ./loopresult/loopfile.txt
echo "Results from makeloopfile.sh file" > ./loopresult/loopfile.txt
for i in {1..20..2}
do
    echo "$i" >> ./loopresult/loopfile.txt
done
echo ""
for i in {2..20..2}
do
    echo -n "$i" >> ./loopresult/loopfile.txt
	if [ "$i" -lt "20" ]; then
		echo -n ", " >> ./loopresult/loopfile.txt
	fi
done
