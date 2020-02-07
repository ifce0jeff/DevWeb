<template>
<body>
  <div>
    <nav class="navbar navbar-expand-sm bg-primary navbar-dark fixed-top">
      <a class="navbar-brand" href="#">
        <img src="../assets/logologin.png" alt="logo" style="width:48px;" />
      </a>

      <ul class="navbar-nav">
        <li class="nav-item">
          <h3>Baratiê</h3>
        </li>
        <li class="nav-item">
          <router-link to="/Home">
            <span class="nav-link">Inicio</span>
          </router-link>
        </li>
        <li class="nav-item">
          <router-link to="/Restaurantes">
            <span class="nav-link">Restaurantes</span>
          </router-link>
        </li>
        <li class="nav-item">
          <router-link to="/Perfil">
            <span class="nav-link">Seu Perfil</span>
          </router-link>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="#">Sobre</a>
        </li>
        <li class="nav-item">
          <router-link to="/">
            <span class="nav-link">Sair</span>
          </router-link>
        </li>
      </ul>
    </nav>

    <figure id="container">
      <img src="../assets/tela1.jpg" class="imgpos" />
      <figcaption>Nossa Praticidade Para Sua Satisfação</figcaption>
    </figure>

    <div>
      <h1 class="primeiro">Bem Vindo ao</h1>
      <h1 class="segundo">Baratiê</h1>
      <hr class="b-hori" />
      <p class="parag">
        Somos um novo nome, mais restaurantes, melhores benefícios
        e o mesmo amor pela comida! O Baratiê vai te ajudar na hora de fazer aquela
        reserva no restaurante que você tanto gosta. Sem burocracia,
        rapido, pratico e eficiente! Tudo para que você desfrute do melhor. Além disso,
        ainda disponibilizamos a opção de o prato ser pedido antes mesmo de você chegar ao local.
        Por menos enrolação e mais apetite!
      </p>
    </div>
    <button class="botao-res" id="log" type="button">Faça Sua Reserva</button>
    <div>
      <img src="../assets/homenjpg.jpg" class="img-homem" />
    </div>
  </div>
</body>
</template>

<script>
</script>

<style scoped>
h3 {
  color: aliceblue;
}
.imgpos {
  position: relative;
  top: 80 px;
  left: 100 px;
}
#container {
  display: inline-block;
  position: relative;
}
#container figcaption {
  position: absolute;
  top: 190px;
  right: 200px;
  font-size: 60px;
  color: rgb(210, 227, 230);
  text-shadow: 0px 0px 5px black;
}
.primeiro {
  position: relative;
  top: 20px;
  left: 50px;
  color: black;
}
.segundo {
  position: relative;
  top: 23px;
  left: 50px;
  color: aqua;
}

.parag {
  font-size: 110%;
  position: relative;
  top: 40px;
  left: 50px;
  margin-right: 60%;
}

.b-hori {
  height: 2px;
  border: none;
  color: #000;
  background-color: #000;
  margin-top: 40px;
  margin-right: 60%;
  margin-bottom: 0px;
  position: relative;
  left: 52px;
}

.img-homem {
  position: relative;
  top: -295px;
  left: 800px;
  width: 36%;
  border-radius: 5%;
}

.botao-res {
  position: relative;
  border: 0;
  background: rgb(10, 25, 231);
  margin: 10px auto;
  text-align: center;
  color: white;
  border: 1.5px solid rgb(123, 146, 248);
  padding: 9px 30px;
  outline: none;
  transition: 0.39s;
  font-size: 14px;
  border-radius: 5px;
  cursor: pointer;
  top: -50%;
  left: 425px;
}

li {
  margin-right: 40px;
}
</style>