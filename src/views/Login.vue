<template>
<body>
  <div class="linha-vertical"></div>
  <img
    src="../assets/fundologin.jpg"
    class="img-responsive"
    alt="Cinque Terre"
    width="1366"
    height="695"
  />
  <div>
    
    <img
    src="../assets/logologin.png"
    class="logo"
  />

    <p class="titulo">Baratiê</p>
    <p class="subtitulo">Descubra restaurantes perto de você!</p>
    <form id="form">
      <h1>Login</h1>
      <input
        class="input"
        type="text"
        name="username"
        v-model="input.username"
        placeholder="Username"
      />
      <input
        class="input"
        type="password"
        name="password"
        v-model="input.password"
        placeholder="Password"
      />
      <router-link to="Home">
        <button class="button" id="log" type="button">Login</button>
      </router-link>
      <button class="button" type="button" v-b-modal.usuario>Cadastro</button>
      <br />
      <button class="a" type="button" v-b-modal.esqueceu>Esqueceu sua senha?</button>
    </form>
  </div>
  <div>
    <b-modal id="esqueceu" centered title="Esqueci Minha Senha" button-size="sm">
      <form ref="form">
        <p>Informe seu e-mail, e enviaremos sua senha !!!</p>
        <b-form-group label="Email" label-for="email-input" invalid-feedback="Email is required">
          <b-form-input id="email-input" v-model="email" required></b-form-input>
        </b-form-group>
      </form>
    </b-modal>
  </div>

  <div>
    <b-modal id="usuario" centered title="Cadastro Usuário" button-size="sm">
      <form ref="form">
        <b-form-group label="Nome" label-for="name-input" invalid-feedback="Name is required">
          <b-form-input id="name-input" v-model="name" required></b-form-input>
        </b-form-group>
        <b-form-group label="Email" label-for="email-input" invalid-feedback="Email is required">
          <b-form-input id="email-input" v-model="email" required></b-form-input>
        </b-form-group>
        <b-form-group label="Telefone" label-for="telefone-input">
          <b-form-input id="telefone-input" v-model="telefone"></b-form-input>
        </b-form-group>
        <b-form-group label="Cidade" label-for="cidade-input">
          <b-form-input id="cidade-input" v-model="cidade"></b-form-input>
        </b-form-group>
        <b-form-group label="Estado" label-for="estado-input">
          <b-form-input id="estado-input" v-model="estado"></b-form-input>
        </b-form-group>
      </form>
    </b-modal>
  </div>
</body>
</template>

<script>
export default {
  name: "Login",
  data() {
    return {
      input: {
        username: "",
        password: ""
      }
    };
  },
  methods: {
    login() {
      if (this.input.username != "" && this.input.password != "") {
        if (
          this.input.username == this.$parent.mockAccount.username &&
          this.input.password == this.$parent.mockAccount.password
        ) {
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
};
</script>

<style scoped>
.logo {
  position: absolute;
  top: 26%;
  width: 285px;
  left: 38%;
}

.a {
  background-color: rgb(0, 6, 24);
  color: rgb(0, 195, 255);
  border-width: 0;
}

.titulo {
  color: white;
  position: absolute;
  top: 42%;
  left: 65%;
  font-size: 400%;
  font-weight: bold;
  text-align: center;
  font-family: Verdana, Geneva, Tahoma, sans-serif;
}

.subtitulo {
  color: aqua;
  position: absolute;
  top: 54%;
  left: 59%;
  font-size: 150%;
  text-align: center;
  font-family: Verdana, Geneva, Tahoma, sans-serif;
}

#form {
  width: 350px;
  padding: 40px;
  position: absolute;
  top: 52%;
  right: 55%;
  transform: translate(-50%, -50%);
  background: rgb(0, 6, 24);
  text-align: center;
  border-radius: 10px;
  opacity: 0.8;
  color: white;
}

.button {
  border: 0;
  background: none;
  display: block;
  margin: 10px auto;
  text-align: center;
  color: white;
  border: 1.5px solid rgb(0, 195, 255);
  padding: 9px 30px;
  outline: none;
  transition: 0.39s;
  font-size: 14px;
  border-radius: 10px;
  cursor: pointer;
  display: inline-block;
}

.input {
  border: 0;
  background: white;
  display: block;
  margin: 20px auto;
  text-align: center;
  color: black;
  border: 1.5px solid rgb(0, 195, 255);
  padding: 14px 10px;
  width: 200px;
  outline: none;
  transition: 0.39s;
  font-size: 14px;
  border-radius: 10px;
}

.fundo {
  background-position: center;
  background-repeat: no-repeat;
  width: 100%;
  background-size: auto;
  overflow: hidden;
}

.linha-vertical {
  top: 10%;
  right: 62%;
  position: absolute;
  color: rgb(255, 255, 255);
  height: 570px; /*Altura da linha*/
  border-left: 3px solid; /* Adiciona borda esquerda na div como ser fosse uma linha.*/
}
</style>