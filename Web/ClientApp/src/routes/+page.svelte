<script>
    import HelloApi from './HelloApi.svelte'
    import '../app.css'
</script>

<svelte:head>
    <title>Home</title>
    <meta name="description" content="Svelte demo app" />
</svelte:head>

<div class="p-4 sm:ml-64">
    <section class="block justify-start text-center items-start">
        <div class="text-4xl text-blue-700 underline font-bold">
            Hello from Tailwind CSS!
        </div>

        <HelloApi />
    </section>
</div>
