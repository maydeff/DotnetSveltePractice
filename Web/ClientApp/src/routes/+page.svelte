<script>
	import HelloApi from "./HelloApi.svelte";
	import "../app.css";
</script>

<svelte:head>
	<title>Home</title>
	<meta name="description" content="Svelte demo app" />
</svelte:head>

<section class="content-center text-center">
	<div class="text-4xl font-bold underline text-blue-700">
		Hello from Tailwind CSS!
	</div>

	<HelloApi />
</section>
