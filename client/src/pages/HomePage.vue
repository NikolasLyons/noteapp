<template>
<div>
  <form @submit.prevent="createNote">

        <div class="form">
          <label for="">Title</label>
          <input type="text" placeholder="Title..." v-model="note.title">

          <label for="">Author</label>
          <input type="text" placeholder="Author..." v-model="note.author">

          <label for="">Description</label>
          <textarea name=""  placeholder="Description..." v-model="note.description" ></textarea>
  
        </div>
        <div>
          <button>Create</button>
        </div>
  </form>
</div>
</template>
<script>
import{ noteService} from '../services/NoteService'
export default{
  name:'HomePage',
  data(){
    return{
      note:{
        title:'',
        author:'',
        description:'',
        todos:[]
      }
    }
  },
  methods:{
   async createNote(){
    console.log(this.note,'this is the note')
    await noteService.createNote(this.note)

    console.log('you have created a Note')

    }
  }
}
</script>
<style>
.form{
  display: flex;
  flex-direction: column;
}
</style>