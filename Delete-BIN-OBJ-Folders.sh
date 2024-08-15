#!/bin/bash

echo "Deleting all BIN and OBJ folders..."
echo

find . -type d -name "bin" -o -name "obj" | while read -r folder; do
    if [[ -d "$folder" ]]; then
        echo "$folder" | grep -qi "\\node_modules\\" && echo "Skipping: $folder" || { echo "Deleting: $folder"; rm -rf "$folder"; }
    fi
done

echo
echo "BIN and OBJ folders have been successfully deleted. Press any key to exit."
read -n 1 -s -r -p "" && echo

