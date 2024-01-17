<template>
<header>

</header>
<main>
  <router-view />
</main>
<footer>

</footer>

</template>
<script>
import { router } from './router';


export default{
    name: 'App',
    components: { router }
}
</script>