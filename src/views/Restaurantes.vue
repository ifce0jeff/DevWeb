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
    <div>
      <table style="margin-top: 100px">
        <thead>
          <tr>
            <th v-for="(i, id) in headerItens" :key="id">{{ i.header }}</th>
          </tr>
        </thead>
        <tbody v-model="restaurantes">
          <tr v-for="(e, id) in restaurantes" :key="id">
            <td>{{ e.nome }}</td>
            <td>{{ e.endereco }}</td>
            <td class="money">
              <div style="display: inline" v-for="(i, id) in e.preco" :key="id">$</div>
            </td>
            <td>
              <v-icon v-for="(i, id) in e.categoria" :key="id" class="star" name="star"></v-icon>
            </td>
            <td>{{ e.especialidade }}</td>
            <td>{{ e.status }}</td>
            <td style="width: 5%"><button class="botao-res" v-b-modal.reserva>Reservar</button></td>
          </tr>
        </tbody>
      </table>
    </div>
  </div>
  <div>
    <b-modal id="reserva" centered title="Reserva" button-size="sm">
      <form ref="form">
        <b-form-group label="Restaurante" label-for="restaurante-input">
          <b-form-input id="restaurante-input" v-model="reserva.restaurante"></b-form-input>
        </b-form-group>
        <b-form-group label="Horário" label-for="hora-input">
          <b-form-input id="hora-input" v-model="reserva.hora"></b-form-input>
        </b-form-group>
      </form>
    </b-modal>
  </div>
</body>
</template>

<script>
import axios from 'axios';
export default {
  data() {
    return {
      headerItens: [
        // { header: "" },
        { header: "Nome" },
        { header: "Endereço" },
        { header: "Preço" },
        { header: "Categoria" },
        { header: "Especialidade" },
        { header: "" }
      ],
      restaurantes: [],
      reserva: {}
    };
  },
  created() {
    axios.get('http://localhost:3000/restaurantes')
    .then(response => {
      this.restaurantes = response.data
      console.log(this.restaurantes);
    })
    .catch(e => {
      this.errors.push(e)
    })
  }
};
</script>

<style scoped>
table {
  box-shadow: 2px 2px 7px 3px rgb(150, 150, 150);
  margin: 15px;
  width: 75%;
  /* text-align: center; */
  overflow: hidden;
  /* border-collapse: separate; */
  border: solid rgb(150, 150, 150) 1px;
  -webkit-border-radius: 10px;
  -moz-border-radius: 10px;
  border-radius: 5px;
  margin: auto;
}

table thead {
  border-collapse: collapse;
}

table td {
  color: #aaa;
  background-color: white;
  padding: 5px;
  border: 1px solid #ddd;
}

.star {
  width: 20px;
  color: rgb(236, 213, 0);
}

.money {
  font-weight: bold;
  font-style: italic;
  color: rgb(0, 180, 0);
}

.botao-res {
  border: 0;
  background: rgb(30,144,255);
  margin: 10px auto;
  text-align: center;
  color: white;
  font-size: 14px;
  border-radius: 5px;
  cursor: pointer;
}

h3 {
  color: aliceblue;
}

li {
  margin-right: 40px;
}
</style>