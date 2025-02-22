const API_URL = "https://localhost:7113/api/User"

async function addUser() {
    
    const response = await fetch(API_URL,{
        method: 'POST'
    });

    if(response.ok){
        alert("Usuário cadastrado")
        getUsers()
    }else{
        console.log(response)
    }
}
async function getUsers(){
    const response = await fetch(API_URL,{
        method: 'GET'
    })
    const users = await response.json()

    const tableBody = document.getElementById("userTable")

    tableBody.innerHTML = ""

    users.forEach(user => {
        const row = document.createElement("tr")

        row.innerHTML = `
            <td>${user.id}</td>
            <td>${user.name}</td>
            <td>${user.email}</td>
            <td>${user.gender}</td>
            <td>${user.cell}</td>
            <td><button onclick="editUser(${user.id},'${user.name}','${user.email}','${user.gender}'
            ,'${user.cell}')">Editar</button></td>
        `
        tableBody.appendChild(row)
    });
}
function editUser(id,name,email,gender,cell){
    document.getElementById("editUserId").value = id
    document.getElementById("editUserName").value = name
    document.getElementById("editUserEmail").value = email
    document.getElementById("editUserGender").value = gender
    document.getElementById("editUserPhone").value = cell

    document.getElementById("editForm").style.display = "block"
}
async function saveEdit(){
    const updateUser={
        "id": document.getElementById("editUserId").value,
        "gender": document.getElementById("editUserGender").value,
        "email": document.getElementById("editUserEmail").value,
        "name": document.getElementById("editUserName").value,
        "cell": document.getElementById("editUserPhone").value
    }
    const response = await fetch(API_URL,{
        method:'PUT',
        headers:{
            'Content-Type':'application/json'
        },
        body: JSON.stringify(updateUser)
    })

    if(response.ok){
        alert("Usuário atualizado")
        getUsers()
        closeEditForm()
    }else{
        console.log(response)
    }
}
function closeEditForm(){
    document.getElementById("editForm").style.display = "none"
}

document.addEventListener("DOMContentLoaded",getUsers)