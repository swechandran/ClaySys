document.getElementById("addTask").onclick = function()
 {
    var taskText = document.getElementById("taskInput").value;
    if (taskText === "") {
        alert("Please enter a task.");
        return;
    }

    //new list
    var newTask = document.createElement("li");
    newTask.textContent = taskText;

    //button
    var completeBtn = document.createElement("button");
            completeBtn.textContent = "Complete";
            completeBtn.className = "taskButtons";
            completeBtn.onclick = function() 
            {
                newTask.classList.toggle("completed");
            };
            newTask.appendChild(completeBtn);
}