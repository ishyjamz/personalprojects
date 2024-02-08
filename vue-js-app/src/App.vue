<template>
    <div class="container">
        <Header title="Ishtiak App" action="Meow" color="blue" />
    </div>
    <div class="container">
        <Header title="To-do List" action="Add Task" />
    </div>
</template>

<script>
import Header from './Header.vue'
export default {
    name: 'App',
    components: {
        Header,
    }
}
</script>

<style>
#app {
    text-align: center;
    margin-top: 70px;
}

.container {
    border: 1px solid steelblue;
    padding: 30px;
    max-width: 500px;
    margin: 20px auto;
    border-width: 5px;
    border-radius: 20px;
}
</style>