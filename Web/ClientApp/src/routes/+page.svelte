<script>
    import HelloApi from './HelloApi.svelte'
    import '../app.css'
</script>

<svelte:head>
    <title>Home</title>
    <meta name="description" content="Svelte demo app" />
</svelte:head>

<div class="p-4">
    <section
        class="block justify-start text-center items-start border-solid border-4 border-cinder-600 bg-cinder-950"
    >
        <div class="text-4xl text-cinder-50 underline font-bold">
            Hello from Tailwind CSS!
        </div>

        <HelloApi />
    </section>
</div>
