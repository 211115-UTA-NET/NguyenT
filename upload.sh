#!/usr/bin/bash

# make file directory variable to read
cwd=$(pwd)
# variable for loop to add more files if user wants to
addfile="Y"

#this loop is for asking to add more files to push
while [ $addfile = "y" ] || [ $addfile = "Y" ]; do
	# --ask to select the file(s) in the working directory--
	echo "Which file(s) should be uploaded in this directory?"
	echo "Current working directory: $cwd"
	echo "Files in this working directory:"
	ls
	read filename
	
	# --check if all files are selected or if no response was made and proceed if conditions are met--
	if [ "${file: -1}" == "." ]; then
		echo "Are you sure you want to upload all files in that directory? Type 'y' to allow."
		read allow
		if [ $allow == "y" ] || [ $allow == "Y" ]; then
			git add "$filename"
		fi
	elif [ -z "$filename" ]; then
		echo "There is no input."
		allow=N
	else
		git add "$filename"
		allow=Y
	fi
	
	# allow to read if file has been added
	if [ $allow == "y" ] || [ $allow == Y ]; then
		echo "Attempted to add $filename to the index."
	fi
	echo "Do you want to add another file? Type 'y' to add another file."
	read addfile
done

#commit and push
echo "Write a commit for the changes made to the files."
read message
echo "type 'y' to push these files for change or type anything else to cancel."
read uploadfile
if [ $uploadfile == y ] || [ $uploadfile == Y ]; then
	if [ -z "$message" ]; then
		git commit -m "A commit has been made."
	else
		git commit -m "$message"
	fi
	git push
fi