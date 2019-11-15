<template>
<body>
      <div class="linha-vertical"></div>
    <img src="./comida.jpg" class="img-responsive" alt="Cinque Terre" width="1366" height="635">
<div>
    <nav class="navbar navbar-expand-sm bg-primary navbar-dark fixed-top">

  <a class="navbar-brand" href="#">
    <img src="./logo.png" alt="logo" style="width:40px;">
  </a>
  
  <ul class="navbar-nav">
    <li class="nav-item">
      <h3>Baratiê</h3>
    </li>
  </ul>
</nav>

    <form id="form">
        <h1>Login</h1>
        <input type="text" name="username" v-model="input.username" placeholder="Username" />
        <input type="password" name="password" v-model="input.password" placeholder="Password" />
        <button id="log" type="button" v-on:click="login()"> Login </button>
        <router-link to="Home">
        </router-link>
        <router-link to="CadastroUsuario">
        <button type="button" >Cadastro</button>

        </router-link>
        <router-link to="RecuperarSenha">
        <a>Esqueceu sua senha?</a>

        </router-link>
    </form>

</div>
</body>
</template>

<script>
    export default {
        name: 'Login',
        data() {
            return {
                input: {
                    username: "",
                    password: ""
                }
            }
        },
        methods: {
            login() {
                if(this.input.username != "" && this.input.password != "") {
                    if(this.input.username == this.$parent.mockAccount.username && this.input.password == this.$parent.mockAccount.password) {
                        this.$emit("authenticated", true);
                        this.$router.replace({ name: "secure" });
                    } else {
                        console.log("The username and / or password is incorrect");
                    }
                } else {
                    console.log("A username and password must be present");
                }
            }
        }
    }
</script>

<style scoped>
   form {
    width: 350px;
	padding: 40px;
	position: absolute;
	top: 54%;
	right: 58%;
	transform: translate(-50%,-50%);
	background: black;
	text-align: center;
	border-radius: 10px;
	opacity: 0.9;
    color: white
    }

    button {
    border: 0;
	background: none;
	display: block;
	margin: 10px auto;
	text-align: center;
	color: white;
	border: 1.5px solid blue;
	padding: 9px 30px;
	outline: none;
	transition: 0.39s;
	font-size: 14px;
	border-radius: 10px;
	cursor: pointer;
    display:inline-block;
    }

    input {
        border: 0;
	background: white;
	display: block;
	margin: 20px auto;
	text-align: center;
	color: black;
	border: 1.5px solid blue;
	padding: 14px 10px;
	width: 200px;
	outline: none;
	transition: 0.39s;
	font-size: 14px;
	border-radius: 10px;
    }

    h3 {
        color: aliceblue
    }

    .fundo {
    background-position: center right;
    background-repeat: no-repeat;
    width: 100%;
    background-size: cover;
    overflow:hidden;
    }

    .linha-vertical {
    top: 17%;
    right: 66%;
    position: absolute;
    color: black;
    height: 530px;/*Altura da linha*/
    border-left: 3px solid;/* Adiciona borda esquerda na div como ser fosse uma linha.*/
}
    
</style>