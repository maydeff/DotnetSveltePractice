<script>
    import HelloApi from './HelloApi.svelte'
    import '../app.css'
    import MainContent from '../MainContent.svelte'
</script>

<svelte:head>
    <title>Home</title>
    <meta name="description" content="Svelte demo app" />
</svelte:head>

<div class="p-4">
    <div class="block justify-start text-center items-start bg-cinder-950">
        <HelloApi />
        <MainContent />
    </div>
</div>
